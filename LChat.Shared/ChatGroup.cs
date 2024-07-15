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
    /// 群聊类
    /// </summary>
    public class ChatGroup
    {
        /// <summary>
        /// 群聊唯一标识ID
        /// </summary>
        [Key]
        public int GroupID { get; set; }

        /// <summary>
        /// 群聊名
        /// </summary>
        [Required]
        public string GroupName { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        public int CreatorID { get; set; }

        /// <summary>
        /// 群主ID
        /// </summary>
        [ForeignKey(nameof(User))]
        public int LeaderID { get; set; }

        /// <summary>
        /// 群主导航属性
        /// </summary>
        public User? Leader { get; set; }

        /// <summary>
        /// 群描述
        /// </summary>
        public string? GroupDescription { get; set; }

        /// <summary>
        /// 群头像
        /// </summary>
        [Required]
        public string GroupAvatar { get; set; }

        /// <summary>
        /// 是否解散
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 群成员列表
        /// </summary>
        public ICollection<User>? Members { get; set; }
    }
}
