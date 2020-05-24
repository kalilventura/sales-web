import { DepartmentService } from './../../../core/services/department/department.service';
import { SellersService } from './../../../core/services/sellers/sellers.service';
import { Seller } from './../../../core/models/seller';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { faTrash, faEdit, faBars } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-list-seller',
  templateUrl: './list-seller.component.html',
  styleUrls: ['./list-seller.component.css']
})
export class ListSellerComponent implements OnInit {

  sellers: Seller[];
  trashIcon = faTrash;
  editIcon = faEdit;
  infoIcon = faBars;
  constructor(private router: Router, private service: SellersService) { }

  ngOnInit(): void {
    this.listSellers(1, 5);
  }

  listSellers(currenPage: number, pageSize: number) {
    this.service.getAllSellers(currenPage, pageSize).subscribe(response => {
      this.sellers = response.data.results;
    });
  }

  createSeller() {
    this.router.navigate(['/seller/create']);
  }

  editSeller(seller: Seller) {
    this.router.navigate([`/seller/edit/${seller.id}`]);
  }

  deleteSeller(seller: Seller) {
    this.router.navigate([`/seller/delete/${seller.id}`]);
  }

  detailSeller(seller: Seller) {
    this.router.navigate([`/seller/detail/${seller.id}`]);
  }

}
