using DiwanModels.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Context;

namespace DiwanControllers.ModelsControllers
{
    public class BaseController<T> where T : BaseModel
    {
        protected readonly DiwanContext _context;

        public BaseController()
        {
            _context = new DiwanContext();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().Where(c => c.IsExist == true).ToList();
        }

        public T GetEntityById(int id)
        {
            return _context.Set<T>().FirstOrDefault(c => c.ID == id && c.IsExist == true);
        }
        public void AddOrUpdate(T entity)
        {
            if (entity.ID == 0)
            {
                _context.Set<T>().Add(entity);
            }
            else
            {
                entity.UpdatedAt = DateTime.Now;
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Remove object softly 
        /// </summary>
        /// <param name="model"></param>
        public void Remove(T entity)
        {
            var entityFromDb = _context.Set<T>().Find(entity.ID);
            if (entityFromDb != null)
            {
                entityFromDb.DeletedAt = DateTime.Now;
                entityFromDb.IsExist = false;
                _context.SaveChanges();
            }
        }
    }
}
