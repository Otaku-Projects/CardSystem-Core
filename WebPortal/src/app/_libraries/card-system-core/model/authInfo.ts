/**
 * WebAPI
 * An ASP.NET Core Web API for managing ToDo items
 *
 * The version of the OpenAPI document: v1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { RouteInfo } from './routeInfo';


export interface AuthInfo { 
    accessToken?: string | null;
    routes?: Array<RouteInfo> | null;
    twoFA?: boolean;
}

