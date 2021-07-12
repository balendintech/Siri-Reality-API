using Siri_Reality_API.DAL;
using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.Service
{
    public class PropertyTypeService : IPropertyTypeService
    {
        protected readonly IPropertyTypeService _propertyRepository;
        public PropertyTypeService(IPropertyTypeService propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public void Delete(int id)
        {
            _propertyRepository.Delete(id);
        }

        public Task<List<PropertyTypes>> GetPropertyTypeList()
        {
            return _propertyRepository.GetPropertyTypeList();
        }

        public PropertyTypes RegisterPropertyTypes(PropertyTypes propertyTypeModel)
        {
            return _propertyRepository.RegisterPropertyTypes(propertyTypeModel);
        }
    }
}
