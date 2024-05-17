import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { addproperty } from 'src/app/models/addproperty.request';
import { city } from 'src/app/models/city.response';
import { furnishingtype } from 'src/app/models/furnishingtype.response';
import { propertytype } from 'src/app/models/propertyType.response';
import { AddpropertyService } from 'src/app/services/addproperty.service';
import { CityService } from 'src/app/services/city.service';
import { FurnishingtypeService } from 'src/app/services/furnishingtype.service';
import { PropertytypeService } from 'src/app/services/propertytype.service';

@Component({
  selector: 'app-addproperty',
  templateUrl: './addproperty.component.html',
  styleUrls: ['./addproperty.component.css']
})
export class AddpropertyComponent {

  addprop:addproperty;
  propertyTypes: propertytype[] | undefined;
  furnishingTypes:furnishingtype[] | undefined ;
  cityprop:city[] | undefined;

  constructor(private addPropertyService: AddpropertyService,
    private propertyTypeService: PropertytypeService,
    private furnishingTypeService :FurnishingtypeService,
    private cityService:CityService,
    private route: Router){
    this.addprop={
      id: 0,
      sellRent:0 ,
      user: 0,
      name: '',
      propertyTypeId: 0,
      furnishingTypeId: 0,
      price: 0,
      bhk: 0,
      builtArea:0 ,
      cityId:0,
      readyToMove: true ,
      carpetArea: 0,
      address1: '',
      address2: '',
      floorNo: 0 ,
      totalFloors: 0 ,
      mainEnterance: '',
      security: 0 ,
      maintenanceAmount: 0,
      ageProperty: 0,
      description:'',
      postedOn: '',
    
    }
  }


  ngOnInit(): void {
    this.propertyTypeService.getPropertyTypes().subscribe(propertyTypes => {
      this.propertyTypes = propertyTypes;
      this.furnishingTypeService.getFurnishingTypes().subscribe(furnishingTypes => {
        this.furnishingTypes = furnishingTypes;
        this.cityService.getCity().subscribe(cityprop => {
          this.cityprop = cityprop;
  
          console.log(this.propertyTypes);
          console.log(this.cityprop);
          console.log(this.furnishingTypes);
        });
      });
    });
  }
  

  onFormSubmit():void{
    this.addPropertyService.createAddProperty(this.addprop)
    .subscribe({
      next:(response) =>{
      this.route.navigateByUrl('/addproperty');


      }
    })

  }

  

}
