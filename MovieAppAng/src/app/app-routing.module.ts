import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';
import { ReactFormComponent } from './react-form/react-form.component';
import { AuthService } from './services/auth.service';
import { AuthGuard } from './guard/auth.guard';
import { CreatedetailsComponent } from './createdetails/createdetails.component';
const routes: Routes = [
  {path:'listmovies',component:ListmovieComponent,canActivate:[AuthGuard]},
  {path:'find/:id',component:FindmovieComponent},
  {path:'add',component:AddMovieComponent},
  {path:'edit/:id',component:EditmovieComponent},
  {path:'delete/:id',component:DeletemovieComponent},
  {path:'reactform',component:ReactFormComponent},
  {path:'details',component:CreatedetailsComponent}
 
  


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers:[AuthService]
})
export class AppRoutingModule { }
