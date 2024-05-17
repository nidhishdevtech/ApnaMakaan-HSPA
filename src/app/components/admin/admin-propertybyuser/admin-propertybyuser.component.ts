import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { propertybyuser } from 'src/app/models/propertybyuser.response';
import { PropertylistService} from 'src/app/services/propertylist.service';

@Component({
  selector: 'app-admin-propertybyuser',
  templateUrl: './admin-propertybyuser.component.html',
  styleUrls: ['./admin-propertybyuser.component.css']
})
export class AdminPropertybyuserComponent {

  properties? :propertybyuser;
  test: any[] = [];
  date =new Date();
  public UserId? :number | null=null ;

  constructor(private propertyService:PropertylistService,
    private route:ActivatedRoute){}


  // sortByPrice():any{
  //  this.properties?.sort((a,b)=>a.builtArea - b.builtArea);
  // }

  sortByPrice(event: Event): void {
    const order = (event.target as HTMLSelectElement).value;
    // if (this.properties) {
    //   this.properties.sort((a, b) => {
    //     if (order === 'desc') {
    //       return b.price - a.price;
    //     } else {
    //       return a.price - b.price;
    //     }
    //   });
    // }
  }

  


 
  ngOnInit():void{
    this.route.paramMap.subscribe({
      next:(params)=>{
        this.UserId=Number(params.get('id'));

        if(this.UserId){
          //get the data from the api for this property id
          this.propertyService.getPropertiesbyUser(this.UserId)
          .subscribe({
            next:(response) =>{
            this.properties = response;
            this.test = response.properties;
            console.log(this.test);
            }
          })
        }
      }
    });
  }

  
  
}
