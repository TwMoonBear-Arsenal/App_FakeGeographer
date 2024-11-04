using Mod_KidasWasm1.L2_DTO;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
namespace Mod_KidasWasm1.L4_Service;

/// <summary>
/// 直連後端KidasServer的服務，就是單純轉發API請求
/// </summary>
public class KidasServerService
{
    private readonly string _Url_KidasServer_GetConsultation;
    private readonly string _Url_KidasServer_GetKnwlModelInfo;
    private readonly string _Url_KidasServer_GetDemoScene;
    private readonly string _Url_KidasServer_GetSceneRevision;
    private readonly string _Url_KidasServer_GetScenePrediction;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url_KidasServer_GetConsultation"></param>
    public KidasServerService(
        String url_KidasServer_GetScenePrediction,
        String url_KidasServer_GetKnwlModelInfo,
        String url_KidasServer_GetDemoScene,
        String url_KidasServer_GetSceneRevision,
        String url_KidasServer_GetConsultation)
    {
        _Url_KidasServer_GetConsultation = url_KidasServer_GetConsultation;
        _Url_KidasServer_GetKnwlModelInfo = url_KidasServer_GetKnwlModelInfo;
        _Url_KidasServer_GetDemoScene = url_KidasServer_GetDemoScene;
        _Url_KidasServer_GetSceneRevision = url_KidasServer_GetSceneRevision;
        _Url_KidasServer_GetScenePrediction = url_KidasServer_GetScenePrediction;
    }

    public async Task<ConsultationRspDTO> GetConsultation(ConsultationReqDTO request)
    {
        using (HttpClient client = new HttpClient())
        {
            // 以RESTFUL方式連接外部推理服務WebApi，取得範例場景
            HttpResponseMessage response = await client.PostAsJsonAsync(_Url_KidasServer_GetConsultation, request);
            try
            {
                ConsultationRspDTO returnValue = await response.Content.ReadFromJsonAsync<ConsultationRspDTO>()
                    ?? throw new Exception("KidasServer_GetConsultation失敗");
                return returnValue;
            }
            catch (Exception)
            {
                throw new Exception("KidasServer_GetConsultation失敗");
            }
        }
    }
}
