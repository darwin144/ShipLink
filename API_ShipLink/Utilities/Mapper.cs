using API_ShipLink.Contract;
using System.Reflection;

namespace API_ShipLink.Utilities
{
    public class Mapper<TModel, TViewModel> : IMapper<TModel, TViewModel>
    {
        private readonly Dictionary<string, PropertyInfo> _viewModelProperties;
        private readonly Dictionary<string, PropertyInfo> _modelProperties;

        public Mapper()
        {
            _viewModelProperties = typeof(TViewModel).GetProperties()
                                                     .ToDictionary(p => p.Name);
            _modelProperties = typeof(TModel).GetProperties()
                                             .ToDictionary(p => p.Name);
        }
        public TViewModel Map(TModel model)
        {
            var viewModel = Activator.CreateInstance<TViewModel>();
            foreach (var viewModelProperty in _viewModelProperties.Values)
            {
                if (!_modelProperties.TryGetValue(viewModelProperty.Name, out var modelProperty)) continue;
                var value = modelProperty.GetValue(model);
                if (value == null) continue;

                viewModelProperty.SetValue(viewModel, value);
            }

            return viewModel;
        }

        public TModel Map(TViewModel viewModel)
        {
            var model = Activator.CreateInstance<TModel>();

            foreach (var modelProperty in _modelProperties.Values)
            {
                if (!_viewModelProperties.TryGetValue(modelProperty.Name, out var viewModelProperty)) continue;
                var value = viewModelProperty.GetValue(viewModel);
                if (value == null) continue;

                modelProperty.SetValue(model, value);
            }
            return model;
        }
    }
}
