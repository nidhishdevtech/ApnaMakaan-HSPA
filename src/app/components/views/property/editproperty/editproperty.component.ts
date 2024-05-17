import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { city } from 'src/app/models/city.response';
import { editproperty } from 'src/app/models/editproperty.request';
import { furnishingtype } from 'src/app/models/furnishingtype.response';
import { propertytype } from 'src/app/models/propertyType.response';
import { CityService } from 'src/app/services/city.service';
import { EditpropertyService } from 'src/app/services/editproperty.service';
import {updateproperty} from 'src/app/models/updateproperty.model';
import { FurnishingtypeService } from 'src/app/services/furnishingtype.service';
import { PropertytypeService } from 'src/app/services/propertytype.service';

@Component({
  selector: 'app-editproperty',
  templateUrl: './editproperty.component.html',
  styleUrls: ['./editproperty.component.css']
})
export class EditpropertyComponent {


  editprop?: editproperty ;
  editpropId : number | null=null;
  routeSubscription?: Subscription;
  updatepropSubscription?: Subscription;
  getpropSubscription?: Subscription;
  propertyTypes: propertytype[] | undefined;
  furnishingTypes:furnishingtype[] | undefined ;
  cityprop:city[] | undefined;

  constructor(private route:ActivatedRoute,
    private editpropService:EditpropertyService,
    private cityService : CityService,
    private router:Router
    ){}



    ngOnInit(): void {
      this.routeSubscription = this.route.paramMap.subscribe({
        next: (params) => {
          this.editpropId = Number(params.get('id'));
          console.log(this.editpropId);
          if (this.editpropId) {
            this.editpropService.getPropertyById(this.editpropId).subscribe({
              next: (response) => {
                response.furnishingTypeId = 2;
                this.editprop = response;
                this.editprop.furnishingTypeId = 2;
                this.cityService.getCity().subscribe(cityprop => {
                  this.cityprop = cityprop;
                });
              }
            });
          }
        }
      });
    }


  //  ngOnInit():void{
  //    this.routeSubscription = this.route.paramMap.subscribe({
  //      next:(params)=>{
  //       this.editpropId = (Number)(params.get('id'));
  //       console.log(this.editpropId);
  //       if(this.editpropId){
  //         this.editpropService.getPropertyById(this.editpropId).subscribe({
  //           next:(response)=>{
  //             this.editprop=response;
  //             this.cityService.getCity().subscribe(cityprop => {
  //                            this.cityprop = cityprop;
  //           }

  //         });
  //       });
  //       }
  //     }
  //  });
  // }

  // ngOnInit(): void {
  //   this.routeSubscription = this.route.paramMap.subscribe({
  //     next: (params) => {
  //       this.editpropId = Number(params.get('editpropId'));
  //       this.propertyTypeService.getPropertyTypes().subscribe(propertyTypes => {
  //         this.propertyTypes = propertyTypes;
  //         this.furnishingTypeService.getFurnishingTypes().subscribe(furnishingTypes => {
  //           this.furnishingTypes = furnishingTypes;
  //           this.cityService.getCity().subscribe(cityprop => {
  //             this.cityprop = cityprop;
  //             console.log(this.propertyTypes);
  //             console.log(this.cityprop);
  //             console.log(this.furnishingTypes);
  //           });
  //         });
  //       });
  //     }
  //   });
  // }



  onFormSubmit() {
    if(this.editprop && this.editpropId){
      var updateprop : updateproperty={
        id :this.editprop.id,
        sellRent :this.editprop.sellRent,
        user: this.editprop.user,
        name:this.editprop.name,
        propertyTypeId: this.editprop.propertyTypeId,
        furnishingTypeId:this.editprop.furnishingTypeId,
        price:this.editprop.price,
        bhk:this.editprop.bhk,
        builtArea:this.editprop.builtArea,
        cityId : this.editprop.cityId,
        readyToMove:this.editprop.readyToMove,
        carpetArea:this.editprop.cityId,
        address1:this.editprop.address1,
        address2:this.editprop.address2,
        floorNo:this.editprop.floorNo,
        totalFloors : this.editprop.totalFloors,
        mainEnterance:this.editprop.mainEnterance,
        security:this.editprop.security,
        maintenanceAmount:this.editprop.maintenanceAmount,
        ageProperty:this.editprop.ageProperty,
        description:this.editprop.description,
        postedOn:this.editprop.postedOn,
        imageUrl:this.editprop.imageUrl
      };
      this.editpropService.updateproperty(this.editpropId,updateprop)
      .subscribe({
        next:(response)=>{
        this.router.navigateByUrl('/admin-propertydetail');


        }
      });
    }
    }

  onDestroy():void{
    this.routeSubscription?.unsubscribe();
    this.updatepropSubscription?.unsubscribe();
    this.getpropSubscription?.unsubscribe();

  }


}