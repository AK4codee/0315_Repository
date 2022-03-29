using _0315_Repository.Commom.Enum;

namespace _0315_Repository.Models
{
    public class ApiResult
    {
        public ApiResult()
        {
            Code = ApiStatus.Success;
        }
        /// <summary>
        /// 自訂義狀態與自定義訊息
        /// </summary>
        public ApiStatus Code { get; set; }
        public string Message { get; set; }
        public object Body { get; set; }
    }
}
