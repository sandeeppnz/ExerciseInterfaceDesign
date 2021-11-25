using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDesign
{
    public class MyStorage
    {
        public static void Run(IReaderWriter readerWriter)
        {
            readerWriter.Initialize();
        }
        public static void StoreInBlob(IReaderWriter readerWriter, Entity entity)
        {
            readerWriter.Write(entity);
        }

        public static Entity GetFromBlob(IReaderWriter readerWriter, int id)
        {
            return readerWriter.Read(id);
        }
    }
}
