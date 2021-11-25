using System;

namespace InterfaceDesign
{
    public class FileReaderWriter<TData> : IReaderWriter<TData> where TData : Entity
    {
        public void Initialize() { throw new NotImplementedException(); }

        public TData Read(int id) { throw new NotImplementedException(); }

        public void Write(TData data) { throw new NotImplementedException(); }

        Entity IReaderWriter.Read(int id) { return Read(id); }

        void IReaderWriter.Write(Entity data) { Write((TData)data); }
    }
}