import{properties} from'../../app/models/properties.response';

export interface propertybyuser{
    "userName": string,
  "fullName": string,
  "phoneNumber": number,
  "properties": properties[];
 
}