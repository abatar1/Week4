using System;
using System.Collections.Generic;

namespace Week4
{
    public class IdCollection
    {
        private Dictionary<Guid, object> guidCollection;
        private Dictionary<object, List<Guid>> reversedGuidCollection;

        public IdCollection()
        {
            guidCollection = new Dictionary<Guid, Object>();
            reversedGuidCollection = new Dictionary<Object, List<Guid>>();
        }

        public TObject Add<TObject>() where TObject : new()
        { 
            var newObject = (TObject)Activator.CreateInstance(typeof(TObject));
            Guid newGuid = Guid.NewGuid();

            guidCollection.Add(newGuid, newObject);
            if (!reversedGuidCollection.ContainsKey(newObject))
                reversedGuidCollection.Add(newObject, new List<Guid>() { } );
            reversedGuidCollection[newObject].Add(newGuid);

            return newObject;
        }

        public Dictionary<Guid, TObject> GetGuids<TObject>(TObject obj)
        {
            var resultDictionary = new Dictionary<Guid, TObject>();
            List<Guid> guidListByType;
            if (!reversedGuidCollection.TryGetValue(obj, out guidListByType))
                return new Dictionary<Guid, TObject>();          

            foreach (var guid in guidListByType)
                resultDictionary.Add(guid, obj);

            return resultDictionary;          
        }

        public TObject GetObject<TObject>(Guid guid)
        {
            object obj;
            if (!guidCollection.TryGetValue(guid, out obj))
                return default(TObject);
            else
                return (TObject)obj;
        }
    }
}
