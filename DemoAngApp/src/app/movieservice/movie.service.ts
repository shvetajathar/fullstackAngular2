import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IMovie } from '../model/imovie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private url='beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io'

  constructor(private httpclient:HttpClient) { }
  getAllMovies():Observable<IMovie>
  {
    return this.ht
  }
}
