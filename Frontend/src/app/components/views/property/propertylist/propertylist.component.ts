import { Component, OnInit } from '@angular/core';
import { propertylistcard } from 'src/app/models/propertylistcard.response';
import { PropertylistService } from 'src/app/services/propertylist.service';

@Component({
  selector: 'app-propertylist',
  templateUrl: './propertylist.component.html',
  styleUrls: ['./propertylist.component.css']
})
export class PropertylistComponent implements OnInit {

  properties? :propertylistcard[];
  date =new Date();

  constructor(private propertyService:PropertylistService){}


  // sortByPrice():any{
  //  this.properties?.sort((a,b)=>a.builtArea - b.builtArea);
  // }

  sortByPrice(event: Event): void {
    const order = (event.target as HTMLSelectElement).value;
    if (this.properties) {
      this.properties.sort((a, b) => {
        if (order === 'desc') {
          return b.price - a.price;
        } else {
          return a.price - b.price;
        }
      });
    }
  }

  


 
  ngOnInit(): void {
    this.propertyService.getAllProperties()
    .subscribe({
      next:(response) =>{
        this.properties=response;
        //this.sortByPrice();
    }
  });
  }

  
  


 }
