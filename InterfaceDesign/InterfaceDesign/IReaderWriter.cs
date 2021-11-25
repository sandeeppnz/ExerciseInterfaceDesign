using System.Collections.Generic;
using System.Text;

namespace InterfaceDesign
{

    public interface IReaderWriter
    {
        void Initialize();
        Entity Read(int id);
        void Write(Entity data);
    }

    public interface IReaderWriter<TEntity> : IReaderWriter where TEntity : Entity
    {
        new TEntity Read(int id);
    }
}
