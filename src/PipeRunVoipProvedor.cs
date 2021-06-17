using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Sufficit.Integration.PipeRun
{
    public class PipeRunVoipProvedor
    {
        /// <summary>
        /// Endereço base dos WebHooks para Voip
        /// </summary>
        public const string Gancho = "https://api.pipe.run/v1/webhooks/webphones/";
        private string Token;

        public PipeRunVoipProvedor(string Token)
        {
            this.Token = Token;
        }

        public ChamadaResposta Atualizar(ChamadaRequisicao processo)
        {
            ChamadaResposta resultado = null;
            System.Net.ServicePointManager.Expect100Continue = true;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, policyErrors) => { return true; } );

            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"{ Gancho }{ Token }");
            httpWebRequest.Timeout = 10000;
            httpWebRequest.AllowWriteStreamBuffering = true;
            httpWebRequest.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";

            //processo.token = httpWebRequest.Headers["token"] = "630a1e4c041ec7d785a5dbf8902615ac5c3890d1787e1";

            var json = JsonConvert.SerializeObject(processo);
            Console.WriteLine($"REQUISICAO :: { json }");
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            WebResponse httpResponse = null;
            try
            {
                httpResponse = httpWebRequest.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"REQUISICAO ERRO :: { ex }");
            }

            if (httpResponse != null)
            {
                string resposta = string.Empty;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resposta = streamReader.ReadToEnd();
                }
                Console.WriteLine($"RESPOSTA :: { resposta }");
                resultado = JsonConvert.DeserializeObject<ChamadaResposta>(resposta);                
            }
            return resultado;
        }
    }
}
