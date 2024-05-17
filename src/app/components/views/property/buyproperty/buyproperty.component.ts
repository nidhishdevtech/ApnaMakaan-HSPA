import { Component } from '@angular/core';
import { propertylistcard } from 'src/app/models/propertylistcard.response';
import { PropertylistService } from 'src/app/services/propertylist.service';

@Component({
  selector: 'app-buyproperty',
  templateUrl: './buyproperty.component.html',
  styleUrls: ['./buyproperty.component.css']
})
export class BuypropertyComponent {
  
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
    this.propertyService.getAllPropertiesforSale()
    .subscribe({
      next:(response) =>{
        this.properties=response;
    }
  });
}
  

}
