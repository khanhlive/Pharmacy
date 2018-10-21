import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DanhmucComponent } from './danhmuc.component';
import { TinhthanhComponent } from './tinhthanh/tinhthanh.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes=[
  {
    path:'',
    component:DanhmucComponent,
    children:[
      {
        path:'tinhthanh',
        component:TinhthanhComponent
      }
    ]
  }
]

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports:[RouterModule],
  declarations: [DanhmucComponent,TinhthanhComponent]
})
export class DanhmucModule { }
