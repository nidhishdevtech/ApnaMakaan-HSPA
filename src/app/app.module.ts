import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';
import {FormsModule} from '@angular/forms'

import { AppRoutingModule } from './app-routing.module';
import{HttpClientModule}from'@angular/common/http';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { PropertylistComponent } from './components/views/property/propertylist/propertylist.component';
import { AddpropertyComponent } from './components/views/property/addproperty/addproperty.component';
import { PropertydetailComponent } from './components/views/property/propertydetail/propertydetail.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatTabsModule} from '@angular/material/tabs';
import {ScrollingModule} from '@angular/cdk/scrolling';
import { FilterPipe } from './pipes/filter.pipe';
import { SortPipe } from './pipes/sort.pipe';
import { BuypropertyComponent } from './components/views/property/buyproperty/buyproperty.component';
import { RentpropertyComponent } from './components/views/property/rentproperty/rentproperty.component';
import { AdminPropertydetailComponent } from './components/admin/admin-propertydetail/admin-propertydetail.component';
import { AdminpageComponent } from './components/views/adminpage/adminpage.component';
import { EditpropertyComponent } from './components/views/property/editproperty/editproperty.component';
import { AdminUserdetailComponent } from './components/admin/admin-userdetail/admin-userdetail.component';
import { AdminPropertybyuserComponent } from './components/admin/admin-propertybyuser/admin-propertybyuser.component';




@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    PropertylistComponent,
    AddpropertyComponent,
    PropertydetailComponent,
    FilterPipe,
    SortPipe,
    BuypropertyComponent,
    RentpropertyComponent,
    AdminPropertydetailComponent,
    AdminpageComponent,
    EditpropertyComponent,
    AdminUserdetailComponent,
    AdminPropertybyuserComponent
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTabsModule,
    ScrollingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
