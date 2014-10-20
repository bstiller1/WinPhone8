using MVVMbasics.Models;

namespace Core.Models
{
    public class SampleModel : BaseModel
    {
        //TODO: Add bindable properties, as shown in the following example
        private int _sampleProperty;
        public int SampleProperty
        {
            get { return _sampleProperty; }
            set { Set(ref _sampleProperty, value); }
        }
    }
}
