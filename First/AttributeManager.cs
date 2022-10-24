using System.Diagnostics;

namespace First
{
    public abstract class AttributeManager
    {
        public virtual void Show(params object[] values)
        {
            foreach (object type in values)
            {
                Debug.Print($"{type.GetType()} - {type}");
            }
        }
    }
}