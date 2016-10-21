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

        public TObject Add<TObject>(Type objectType) where TObject : new()
        { 
            var newObject = (TObject)Activator.CreateInstance(objectType);
            Guid newGuid = Guid.NewGuid();

            guidCollection.Add(newGuid, newObject);
            if (reversedGuidCollection.ContainsKey(newObject))
                reversedGuidCollection[newObject].Add(newGuid);
            else
                reversedGuidCollection.Add(newObject, new List<Guid>() { newGuid });

            return newObject;
        }

        public Dictionary<Guid, TObject> GetGuids<TObject>(TObject obj)
        {
            try
            {
                var guidListByType = reversedGuidCollection[obj];
                var resultDictionary = new Dictionary<Guid, TObject>();

                foreach (var guid in guidListByType)
                    resultDictionary.Add(guid, obj);

                return resultDictionary;
            }
            catch (Exception ex)
            {
                return new Dictionary<Guid, TObject>();
            }            
        }

        public TObject GetObject<TObject>(Guid guid)
        {
            try
            {
                return (TObject)guidCollection[guid];
            }
            catch (Exception ex)
            {
                return default(TObject);
            }
        }
    }
}
