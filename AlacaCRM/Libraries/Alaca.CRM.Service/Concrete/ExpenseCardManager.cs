using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.Validations.FluentValidation;
using Alaca.Core.Aop.Autofac;

namespace Alaca.CRM.Service.Concrete
{
    public class ExpenseCardManager : IExpenseCardService
    {
        IExpenseCardDal _expenseCardDal;
        public ExpenseCardManager(IExpenseCardDal expenseCardDal)
        {
            _expenseCardDal = expenseCardDal;
        }

        [Validation(typeof(ExpenseCardValidator))]
        public async Task<IResult> Add(ExpenseCard data)
        {
            await _expenseCardDal.Insert(data);
            return new SuccessResult("Masraf Eklendi.", data.ExpenseCardId);
        }

        public async Task<IResultData<List<ExpenseCard>>> GetAllList()
        {
            var data = await _expenseCardDal.GetAllList();
            return new SuccessResultData<List<ExpenseCard>>(data);
        }

        public async Task<IResultData<ExpenseCard>> GetById(Guid Id)
        {
            return new SuccessResultData<ExpenseCard>(await _expenseCardDal.Get(p => p.ExpenseCardId == Id));
        }

        public async Task<IResult> Remove(ExpenseCard data)
        {
            await _expenseCardDal.Delete(data);
            return new SuccessResult("Masraf Silindi.", data.ExpenseCardId);
        }

        [Validation(typeof(ExpenseCardValidator))]
        public async Task<IResult> Update(ExpenseCard data)
        {
            await _expenseCardDal.Update(data);
            return new SuccessResult("Masraf Güncellendi.", data.ExpenseCardId);
        }
    }
}
