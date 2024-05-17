import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  // transform(value: any[], filterString: string , propName:string): any[] {
  //   const resultArray = [];
  //   if (value.length === 0 || filterString==='' ||  propName==='') {
  //     return value;

  //   }

  //   for(const item of value) {
  //     if(item[propName]=== filterString){
  //       resultArray.push(item);
  //     }
  //   }

  //   return resultArray;
    

  // }

  transform(value: any[], filters: {propName: string, filterString: string}[]): any[] {
    const resultArray = [];
    if (value.length === 0 || filters.length === 0) {
      return value;
    }
  
    for(const item of value) {
      let match = true;
      for(const filter of filters) {
        if(item[filter.propName] !== filter.filterString){
          match = false;
          break;
        }
      }
      if(match) {
        resultArray.push(item);
      }
    }
  
    return resultArray;
  }

}
