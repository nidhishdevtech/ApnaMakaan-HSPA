import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddpropertyComponent } from './components/views/property/addproperty/addproperty.component';
import { BuypropertyComponent } from './components/views/property/buyproperty/buyproperty.component';
import {RentpropertyComponent } from './components/views/property/rentproperty/rentproperty.component'
import { PropertydetailComponent } from './components/views/property/propertydetail/propertydetail.component';
import { PropertylistComponent } from './components/views/property/propertylist/propertylist.component';
import { AdminpageComponent } from './components/views/adminpage/adminpage.component';
import{AdminPropertydetailComponent} from'./components/admin/admin-propertydetail/admin-propertydetail.component'
import { EditpropertyComponent } from './components/views/property/editproperty/editproperty.component';
import { UserdetailService } from './services/userdetail.service';
import { AdminUserdetailComponent } from './components/admin/admin-userdetail/admin-userdetail.component';
import { AdminPropertybyuserComponent } from './components/admin/admin-propertybyuser/admin-propertybyuser.component';


const routes: Routes = [
  {path:'',component:PropertylistComponent},
  {path:'addproperty', component:AddpropertyComponent},
  {path:'propertydetail/:id', component:PropertydetailComponent},
  {path:'buyproperty', component:BuypropertyComponent},
  {path:'rentproperty', component:RentpropertyComponent},
  {path:'adminpage', component:AdminpageComponent},
  {path:'admin-propertydetail',component:AdminPropertydetailComponent},
  {path:'admin/editproperty/:id', component:EditpropertyComponent},
  {path:'admin-userdetails',component:AdminUserdetailComponent},
  {path:'admin-propertybyuser',component:AdminPropertybyuserComponent},
  {path :'admin-propertybyuser/:id',component:AdminPropertybyuserComponent}
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
