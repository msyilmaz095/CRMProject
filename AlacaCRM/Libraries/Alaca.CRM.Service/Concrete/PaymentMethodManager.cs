using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class PaymentMethodManager : IPaymentMethodService
    {
        IPaymentMethodDal _paymentMethodDal;
        public PaymentMethodManager(IPaymentMethodDal paymentMethodDal)
        {
            _paymentMethodDal = paymentMethodDal;
        }
        public async Task<IResult> Add(PaymentMethod data)
        {
            await _paymentMethodDal.Insert(data);
            return new SuccessResult("Ödeme Şekli Eklendi.", data.PaymentMethodId);
        }

        public async Task<IResultData<List<PaymentMethod>>> GetAllList()
        {
            var data = await _paymentMethodDal.GetAllList();
            return new SuccessResultData<List<PaymentMethod>>(data);
        }

        public async Task<IResultData<PaymentMethod>> GetById(Guid Id)
        {
            return new SuccessResultData<PaymentMethod>(await _paymentMethodDal.Get(p => p.PaymentMethodId == Id));
        }

        public async Task<IResult> Remove(PaymentMethod data)
        {
            await _paymentMethodDal.Delete(data);
            return new SuccessResult("Ödeme Şekli Silindi.", data.PaymentMethodId);
        }

        public async Task<IResult> Update(PaymentMethod data)
        {
            await _paymentMethodDal.Update(data);
            return new SuccessResult("Ödeme Şekli Güncellendi.", data.PaymentMethodId);
        }
    }
}