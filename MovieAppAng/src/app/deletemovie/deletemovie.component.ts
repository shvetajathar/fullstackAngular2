import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../services/movieservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-deletemovie',
  templateUrl: './deletemovie.component.html',
  styleUrls: ['./deletemovie.component.css']
})
export class DeletemovieComponent implements OnInit {

  constructor(private ms:MovieserviceService,private route:Router,private ar:ActivatedRoute) { }
moviedata:IMovie
id:number



ngOnInit() {
  const tid=this.ar.snapshot.paramMap.get('id')
  this.id=Number(tid)
  this.getMovie(this.id)
}

saveData(movie:IMovie)
{
  this.moviedata=movie
  this.ms.deleteMovie(this.moviedata).subscribe(()=>{
    alert("record deleted")
    this.route.navigate(['/listmovies'])
  })
}

}
