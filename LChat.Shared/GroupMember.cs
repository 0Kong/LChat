using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LChat.Shared
{
    /// <summary>
    /// 群关系表
    /// </summary>
    public class GroupMember
    {
        /// <summary>
        /// 群关系唯一标识ID
        /// </summary>
        [Key]
        public int MemberID { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        [ForeignKey(nameof(ChatGroup))]
        public int GroupID { get; set; }

        /// <summary>
        /// 群导航属性
        /// </summary>
        public ChatGroup? ChatGroup { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        /// <summary>
        /// 用户导航属性
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// 群内角色
        /// </summary>
        public RoleInGroup RoleInGroup { get; set; }
    }

    public enum RoleInGroup
    {
        Leader,//群主
        Administrator,//管理员
        Ordinary//普通群友
    }
}
