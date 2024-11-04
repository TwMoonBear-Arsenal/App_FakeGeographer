using System.Text.Json.Serialization;

namespace Mod_KidasWasm1.L2_DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsultationReqDTO
    {
        /// <summary>
        /// 聊天訊息的列表，包含不同的角色（系統、使用者、助理）的訊息。
        /// </summary>
        [JsonPropertyName("messages")]
        public List<ConsultationMsgDTO> Messages { get; set; } = new List<ConsultationMsgDTO>();
    }
}
