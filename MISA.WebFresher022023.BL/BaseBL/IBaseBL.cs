using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.BL.BaseBL
{
    public interface IBaseBL<T>
    {
        /// <summary>
        /// Lấy thông tin bản ghi theo Id
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public T GetRecordById(Guid recordId);

        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public IEnumerable<T> GetRecords();

        /// <summary>
        /// Thêm bản ghi mới
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int AddRecord(T record);

        /// <summary>
        /// Cập nhật thông tin bản ghi 
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int UpdateRecord(T record);

        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="recordIds"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int DeleteRecords(String recordIds);
    }
}

