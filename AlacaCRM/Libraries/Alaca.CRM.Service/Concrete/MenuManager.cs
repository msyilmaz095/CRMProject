
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }
        public async Task<IResult> Add(Menu data)
        {
            await _menuDal.Insert(data);
            return new SuccessResult("Menu Eklendi.");
        }

        public async Task<IResultData<List<Menu>>> GetAllList()
        {
            var data = await _menuDal.GetAllList();
            return new SuccessResultData<List<Menu>>(data);
        }

        public async Task<IResultData<Menu>> GetById(Guid Id)
        {
            return new SuccessResultData<Menu>(await _menuDal.Get(p => p.MenuId == Id));
        }


        public async Task<IResult> Remove(Menu data)
        {
            await _menuDal.Delete(data);
            return new SuccessResult("Menu Silindi.");
        }

        public async Task<IResult> Update(Menu data)
        {
            await _menuDal.Update(data);
            return new SuccessResult("Menu Güncellendi.");
        }
    }

}