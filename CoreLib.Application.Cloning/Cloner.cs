using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CoreLib.Application.Cloning
{
    /// <summary>
    /// Class that provides methods to copy objects.
    /// </summary>
    public static class Cloner
    {
        /// <summary>
        /// Create a copy of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object">The object to be copied.</param>
        /// <returns>The copy of the object.</returns>
        /// <include file='Documentation.xml' path='Documentation/Classes/members[@name="Cloner"]/Cloner/*'/>
        public static T Clone<T>(T @object)
        {
            if(!typeof(T).IsSerializable)
                throw new ArgumentException($"{nameof(@object)} must be serializable.", nameof(@object));
            if(object.ReferenceEquals(@object, null))
                throw new ArgumentNullException(nameof(@object));

            IFormatter formatter = new BinaryFormatter();
            using(var stream = new MemoryStream())
            {
                formatter.Serialize(stream, @object);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}