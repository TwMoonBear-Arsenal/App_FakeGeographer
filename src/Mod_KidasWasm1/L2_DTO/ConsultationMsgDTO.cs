using Mod_KidasWasm1.L2_DTO;
using System.Text.Json.Serialization;

namespace Mod_KidasWasm1.L2_DTO
{
    /// <summary>
    /// 代表一句聊天發言
    /// </summary>
    public class ConsultationMsgDTO
    {
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        public ConsultationMsgDTO(string role, string content)
        {
            Role = role;
            Content = content;
        }

        /// <summary>
        /// 訊息角色
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// 訊息的具體內容。
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
