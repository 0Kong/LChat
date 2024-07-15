using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LChat.Shared
{
    /// <summary>
    /// 消息类，包括文字，图片，视频，音频，压缩包等文件
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 消息唯一标识ID
        /// </summary>
        [Key]
        public int MessageID { get; set; }

        /// <summary>
        /// 消息发送方ID
        /// </summary>
        [ForeignKey(nameof(User))]
        public int SenderID { get; set; }

        /// <summary>
        /// 外键的导航属性
        /// </summary>
        public User? Sender { get; set; }

        //[ForeignKey(nameof(User))]
        //public int ReceiverID { get; set; }

        /// <summary>
        /// 消息内容（可能是纯文本或文件引用）
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// 消息类别
        /// </summary>
        [Required]
        public string MessageType { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 是否撤回
        /// </summary>
        public bool IsWithdrawn { get; set; }
    }
}
