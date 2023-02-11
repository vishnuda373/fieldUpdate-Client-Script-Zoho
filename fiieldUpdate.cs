var owner_id = ZDK.Page.getField("Owner").getValue().id;
var owner_record = ZDK.Apps.CRM.Branch_Users.searchByCriteria("(User_ID:equals:"+ owner_id +")");
var branch_id = owner_record[0].Branch_Lookup_Id;
var branch_record = ZDK.Apps.CRM.Branches.fetchById(branch_id);
var branch = branch_record.Name;
log(branch);
ZDK.Page.getField('Branch').setValue(branch);

    