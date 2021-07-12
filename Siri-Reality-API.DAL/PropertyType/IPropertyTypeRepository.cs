using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.DAL
{
    public interface IPropertyTypeRepository
    {
        PropertyTypes RegisterPropertyTypes(PropertyTypes propertyTypeModel);
        Task<List<PropertyTypes>> GetPropertyTypeList();
        void Delete(int id);
    }
}
