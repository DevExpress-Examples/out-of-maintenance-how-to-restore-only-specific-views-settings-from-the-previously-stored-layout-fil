using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Serializing;
using DevExpress.Utils.Serializing.Helpers;
using System.IO;

namespace FilterDeserializer {
    public class FilterDeserializer : XmlXtraSerializer {
        static FilterDeserializer instance = null;
        public static FilterDeserializer Instance {
            get {
                if(instance == null)
                    instance = new FilterDeserializer();
                return instance;
            }
        }
        public static void LoadFilter(ColumnView view, string file) {
            IXtraPropertyCollection collection = Instance.Deserialize(file, "View", null);
            Instance.DeserializeObject(view, GetFilterCollection(view, collection), view.OptionsLayout);
        }
        static IXtraPropertyCollection GetFilterCollection(ColumnView view, IXtraPropertyCollection collection) {
            string filterNames = "|ActiveFilterEnabled|ActiveFilterString|MRUFilters|";
            IXtraPropertyCollection ret;
            using(Stream ms = new MemoryStream()) {
                view.SaveLayoutToStream(ms, view.OptionsLayout);
                ms.Position = 0;
                ret = Instance.Deserialize(ms, "View", null);
                foreach(XtraPropertyInfo pi in collection)
                    if(filterNames.Contains(string.Format("|{0}|", pi.Name)))
                        ret.Add(pi);
            }
            return ret;
        }
    }
}
