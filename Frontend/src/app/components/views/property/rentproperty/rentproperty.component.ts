import { Component } from '@angular/core';
import { propertylistcard } from 'src/app/models/propertylistcard.response';
import { PropertylistService } from 'src/app/services/propertylist.service';

@Component({
  selector: 'app-rentproperty',
  templateUrl: './rentproperty.component.html',
  styleUrls: ['./rentproperty.component.css']
})
export class RentpropertyComponent {
  

  properties? :propertylistcard[];
  date =new Date();

  constructor(private propertyService:PropertylistService){}


  
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
    this.propertyService.getAllPropertiesforRent()
    .subscribe({
      next:(response) =>{
        this.properties=response;
    }
  });
  }


  




  
}
