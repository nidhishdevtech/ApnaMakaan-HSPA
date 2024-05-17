import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { propertydetail } from 'src/app/models/propertydetail.response';
import { PropertydetailService } from 'src/app/services/propertydetail.service';

@Component({
  selector: 'app-propertydetail',
  templateUrl: './propertydetail.component.html',
  styleUrls: ['./propertydetail.component.css']
})
export class PropertydetailComponent implements OnInit , OnDestroy {

  public propertyId? :number | null=null ;
  paramsSubscription?: Subscription;
  property?:propertydetail;
  

  constructor(private route: ActivatedRoute,
    private propertydetailService:PropertydetailService) {}

  ngOnInit():void{
    this.route.paramMap.subscribe({
      next:(params)=>{
        this.propertyId=Number(params.get('id'));

        if(this.propertyId){
          //get the data from the api for this property id
          this.propertydetailService.getPropertyById(this.propertyId)
          .subscribe({
            next:(response) =>{
            this.property = response;
            }
          })
        }
      }
    });
  }

  ngOnDestroy():void{
    this.paramsSubscription?.unsubscribe();
  }

  items = Array(10).fill(0).map((_, i) => i);


}
