using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CoreLib.Application.Clonning
{
    public static class Cloner
    {
        public static T Clone<T>(T source)
        {
            #region Guards
            if(!typeof(T).IsSerializable)
                throw new ArgumentException($"{nameof(source)} must be serializable.", nameof(source));
            if(object.ReferenceEquals(source, null))
                return default(T);
            #endregion

            IFormatter formatter = new BinaryFormatter();
            using(var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
