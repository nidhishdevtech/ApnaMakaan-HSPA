import { Component } from '@angular/core';
import { propertylistcard } from 'src/app/models/propertylistcard.response';
import { PropertylistService } from 'src/app/services/propertylist.service';
import { DeleteService } from 'src/app/services/delete.service';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-propertydetail',
  templateUrl: './admin-propertydetail.component.html',
  styleUrls: ['./admin-propertydetail.component.css']
})
export class AdminPropertydetailComponent {

  id: number | null=null;
  deletePropertySubscription?:Subscription;


  properties? :propertylistcard[];

  constructor(private propertyService : PropertylistService,
    private deleteService:DeleteService,
    private router:Router){}

  ngOnInit(): void {
    this.propertyService.getAllProperties()
    .subscribe({
      next:(response) =>{
        this.properties=response;
        //this.sortByPrice();
    }
  });
  }


  onDelete(id : number) : void{
    if (id){
      this.deletePropertySubscription=this.deleteService.deleteProperty(id)
      .subscribe({
        next:(response)=>{
          console.log("Deleted successfully");
          this.router.navigate(['/admin-propertydetail']);
        }
      })
      }
      
  }

  onDestroy():void{
    this.deletePropertySubscription?.unsubscribe();
  }

}
