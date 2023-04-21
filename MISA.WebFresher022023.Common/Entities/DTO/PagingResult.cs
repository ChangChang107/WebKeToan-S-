namespace MISA.WebFresher022023.Common.Entities.DTO
{
    public class PagingResult<T>
    {
        public List<T> Data { get; set; }

        public int TotalRecord { get; set; }
    }
}