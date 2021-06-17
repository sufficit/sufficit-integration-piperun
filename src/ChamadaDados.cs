using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Integration.PipeRun
{
    public class ChamadaDados
    {
        #region EXEMPLO DE DADOS
        /*
        "id": 582133,
        "account_id": 1,
        "user_id": 1,
        "from_user_id": 1,
        "deal_id": 1891456,
        "company_id": null,
        "person_id": 705563,
        "webphone_id": 1,
        "webphone_extension_id": 1,
        "username": null,
        "from_number": "3016",
        "to_number": "55999999999",
        "record_audio": null,
        "from_caller_id": "3016",
        "to_caller_id": null,
        "description": null,
        "start_at": "2019-03-10 17:16:18",
        "end_at": "2019-03-10 17:19:35",
        "status": 200,
        "record_url": null,
        "external_call_id": 3572,
        "json_return": {
            "id": 582133,
            "start_at": "2019-03-10 17:16:18",
            "end_at": "2019-03-10 17:19:35",
            "status": 200,
            "record_url": null,
            "external_call_id": 3572,
            "duration": "00:03:17",
            "cost": 0.79
        },
        "important": null,
        "duration": "00:03:17",
        "cost": 0.79,
        "created_at": "2019-03-21 16:50:49",
        "updated_at": "2019-03-21 16:52:13"        
        */
        #endregion

        public string id { get; set; }
        public string account_id { get; set; }
        public string user_id { get; set; }
        public string from_user_id { get; set; }
        public string deal_id { get; set; }
        public string company_id { get; set; }
        public string person_id { get; set; }
        public string webphone_id { get; set; }
        public string webphone_extension_id { get; set; }
        public string username { get; set; }
        public string from_number { get; set; }
        public string to_number { get; set; }
        public string record_audio { get; set; }
        public string from_caller_id { get; set; }
        public string to_caller_id { get; set; }
        public string description { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public string status { get; set; }
        public string record_url { get; set; }
        public string external_call_id { get; set; }
        public string important { get; set; }
        public string duration { get; set; }
        public string cost { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public ChamadaRequisicao json_return { get; } = new ChamadaRequisicao();
    }
}
