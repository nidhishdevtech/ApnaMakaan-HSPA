import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { User } from 'src/app/models/userdetail.response';
import { UserdetailService } from 'src/app/services/userdetail.service';
import {DeleteService} from 'src/app/services/delete.service'

@Component({
  selector: 'app-admin-userdetail',
  templateUrl: './admin-userdetail.component.html',
  styleUrls: ['./admin-userdetail.component.css']
})
export class AdminUserdetailComponent {

  users?:User[];
  id:number | null=null;


  deleteUserSubscription?:Subscription;

  constructor(private userDetailService:UserdetailService,
    private deleteService: DeleteService,
    private router:Router){}

  ngOnInit():void{
    this.userDetailService.getAllUser()
      .subscribe({
        next:(response)=>{
          this.users=response;
        }
      });

  }

  onDelete(id : number) : void{
    if (id){
      this.deleteUserSubscription=this.deleteService.deleteUser(id)
      .subscribe({
        next:(response)=>{
          console.log("Deleted successfully");
          this.router.navigateByUrl('/admin-userdetails');
        }
      })
      }
      
  }

  onDestroy():void{
    this.deleteUserSubscription?.unsubscribe();
  }
    
    
    



  

}
