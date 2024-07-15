using System.ComponentModel.DataAnnotations;

namespace LChat.Shared
{
    /// <summary>
    /// 最基础的用户类，所有角色都使用此类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户唯一标识ID
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string? UserEmail { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string? UserPhone { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [Required]
        public string Avatar { get; set; }

        /// <summary>
        /// 用户呢称
        /// </summary>
        [Required]
        public string Nickname { get; set; }

        /// <summary>
        /// 标识用户是否被封禁
        /// </summary>
        public bool IsBanned { get; set; }

        /// <summary>
        /// 标识用户是否注销删除账号
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 用户主要角色
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// 好友列表
        /// </summary>
        public ICollection<User>? Friends { get; set; }

    }

    public enum Role
    {
        SuperAdmin,//超级管理员
        Admin,//普通管理员
        GenlUser//普通用户
    }
}
