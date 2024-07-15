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
    /// 用户与用户之间的关系，单向存储，双向查找
    /// </summary>
    public class Friendship
    {
        /// <summary>
        /// 关系唯一标识ID
        /// </summary>
        [Key]
        public int FriendshipID { get; set; }

        /// <summary>
        /// 用户1
        /// </summary>
        [ForeignKey(nameof(User))]
        public int UserID_1 { get; set; }

        /// <summary>
        /// 用户1导航属性
        /// </summary>
        public User? User_1 { get; set; }

        /// <summary>
        /// 用户2
        /// </summary>
        [ForeignKey(nameof(User))]
        public int UserID_2 { get; set; }

        /// <summary>
        /// 用户2导航属性
        /// </summary>
        public User? User_2 { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        public FriendshipStatus FriendshipStatus { get; set; }
    }

    /// <summary>
    /// 具体关系类型，获取好友列表时只获取已同意
    /// </summary>
    public enum FriendshipStatus
    {
        Requesting,//请求中
        Agreed,//已同意
        Rejected//已拒绝
    }
}
