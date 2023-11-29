import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private url:string = "https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/api/User" ;

  constructor(private httpclient:HttpClient) { }
  getUsers()
  {
    return this.httpclient.get<any>(this.url);
  }
}
