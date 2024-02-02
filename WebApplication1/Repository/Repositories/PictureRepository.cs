using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PictureRepository : IRepository<Picture>
    {
        private readonly IContext context;
        public PictureRepository(IContext context)
        {
            this.context = context;
        }
        public void Add(Picture item)
        {
            this.context.Pictures.Add(item);
            this.context.save();
        }

        public void Delete(Picture item)
        {
            this.context.Pictures.Remove(item);
        }

        public List<Picture> GetAll()
        {
            return this.context.Pictures.ToList();
        }

        public Picture GetById(int id)
        {
            return this.context.Pictures.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Picture item)
        {
            var Picture = this.context.Pictures.FirstOrDefault(x => x.Id == id);
            Picture.Name = item.Name;
            this.context.save();
        }
    }
}
