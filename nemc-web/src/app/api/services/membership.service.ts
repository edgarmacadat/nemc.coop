/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { MembershipDTO } from '../models/membership-dto';
@Injectable({
  providedIn: 'root',
})
class MembershipService extends __BaseService {
  static readonly getMembershipPath = '/Membership';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  getMembershipResponse(): __Observable<__StrictHttpResponse<Array<MembershipDTO>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/Membership`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<MembershipDTO>>;
      })
    );
  }
  /**
   * @return Success
   */
  getMembership(): __Observable<Array<MembershipDTO>> {
    return this.getMembershipResponse().pipe(
      __map(_r => _r.body as Array<MembershipDTO>)
    );
  }
}

module MembershipService {
}

export { MembershipService }
