using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.Xpo;

namespace AccessActionControl.Module.Win {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
        }
    }
}