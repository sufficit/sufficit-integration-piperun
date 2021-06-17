using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Integration.PipeRun
{
    public class ChamadaRequisicao
    {
        #region EXEMPLO DE REQUISICAO
        /*
        "id":6473,
        "start_at":"2019-03-10 17:16:18",
        "end_at":"2019-03-10 17:19:35",
        "status":200,
        "record_url":"http://caminho/do/recurso.mp3",
        "external_call_id":3572,
        "duration":"00:03:17",
        "cost":0.79
        */
        #endregion

        public string id { get; set; }
        public string start_at { get; set; } = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
        public string end_at { get; set; } = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
        public string status { get; set; }
        public string record_url { get; set; }
        public string external_call_id { get; set; }
        public string duration { get { return (DateTime.Parse(end_at) - DateTime.Parse(start_at)).ToString(@"hh\:mm\:ss"); } }
        public string cost { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
