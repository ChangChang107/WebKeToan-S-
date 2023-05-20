using MISA.WebFresher022023.Common.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher022023.Common.Exceptions
{
    public class MValidateException : Exception
    {
        ErrorService MsgErrorValidate = null;
        public MValidateException(ErrorService msg) {
            this.MsgErrorValidate = msg;
        }

        public ErrorService Message { get { return MsgErrorValidate;} }
    }
}
