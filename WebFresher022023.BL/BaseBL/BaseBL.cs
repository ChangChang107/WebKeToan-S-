using MISA.WebFresher022023.Common.Entities;
using MISA.WebFresher022023.DL.BaseDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.BL.BaseBL
{
    public class BaseBL<T> : IBaseBL<T>
    {
        IBaseDL<T> _baseDL;
        public BaseBL(IBaseDL<T> baseDL)
        {
            _baseDL = baseDL;
        }

        /// <summary>
        /// Thêm bản ghi mới
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int AddRecord(T record)
        {
            // Validate Dữ liệu
            ValidateData(record);

            // Thêm mới dữ liệu
            var res = _baseDL.AddRecord(record);
            return res;
        }

        /// <summary>
        /// Xóa nhiều bản ghi
        /// </summary>
        /// <param name="recordIds"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int DeleteRecords(String recordIds)
        {
            var res = _baseDL.DeleteRecords(ConvertStringToArray(recordIds));
            return res;
        }

        /// <summary>
        /// Lấy thông tin bản ghi theo Id
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public T GetRecordById(Guid recordId)
        {
            var res = _baseDL.GetRecordById(recordId);
            return res;
        }

        /// <summary>
        /// Lấy danh sách bản ghi
        /// </summary>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public IEnumerable<T> GetRecords()
        {
            var res = _baseDL.GetRecords();
            return res;
        }

        /// <summary>
        /// Cập nhật thông tin bản ghi 
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>        
        /// By: NTTrang
        /// date: 8/4/2023
        public int UpdateRecord(T record)
        {
            // validate data
            ValidateData(record);

            // update du lieu
            var res = _baseDL.UpdateRecord(record);
            return res;
        }

        /// <summary>
        /// validate du lieu
        /// </summary>
        /// <param name="record"></param>
        protected virtual void ValidateData(T  record)
        {

        }

        /// <summary>
        /// Ham tach chuoi thanh mang cac phan tu co kieu du lieu Guid
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Guid[] ConvertStringToArray(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new Guid[0];
            }

            int inputLength = input.Length;
            int arrayLength = (inputLength + 35) / 36;
            Guid[] result = new Guid[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                int startIndex = i * 36;
                int length = Math.Min(36, inputLength - startIndex);
                result[i] = Guid.Parse(input.Substring(startIndex, length));
            }

            return result;
        }
    }
}
