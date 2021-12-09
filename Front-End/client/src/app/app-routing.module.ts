import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ExercisesComponent } from './exercises/exercises.component';
import { HistoryComponent } from './history/history.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { WorkoutsComponent } from './workouts/workouts.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
{path:'', component: HomeComponent},
{
  path: '',
  runGuardsAndResolvers: 'always',
  canActivate: [AuthGuard],
  children: [
  {path:'exercises', component: ExercisesComponent},
  {path:'workouts', component: WorkoutsComponent},
  {path:'history', component: HistoryComponent},
  ]
},
{path:'errors', component: TestErrorsComponent},
{path:'register', component: RegisterComponent},
{path:'**', component: HomeComponent, pathMatch: 'full'}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
