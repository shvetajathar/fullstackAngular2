import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private url="https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/api/User";

  constructor(private httpclient:HttpClient,private router:Router) { }
  isLoggedIn():boolean
  {

    return !! localStorage.getItem('token')
  }
  signUp(userObj:any)
  {
    return  this.httpclient.post<any>(`${this.url}register`,userObj)
  }
  signIn(loginObj:any)
  {
    return  this.httpclient.post<any>(`${this.url}authenticate`,loginObj)
    
  }
  signOut(){
    localStorage.clear()
    this.router.navigate(['login'])
  }
  storeToken(tokenValue:string)
  {
    localStorage.setItem('token',tokenValue)
  }
  getToken()
  {
    return localStorage.getItem('token')
  }
  private userPayload:any
  getFullNameFromToken(){
    if(this.userPayload)
    {
      return this.userPayload.name
    }
  }
  getRoleFromToken(){
    if(this.userPayload)
    {
      return this.userPayload.role
    }
  }
}
