import {createBrowserRouter} from "react-router-dom";

import Explore from "../pages/explore";
import Notifications from "../pages/notifications";
import Home from "~/pages/home";

 const routes =  createBrowserRouter([{
    path: '/',
    element: <Home />
},
{
    path: '/explore',
    element: <Explore/>
},
{
    path: '/notifications',
    element: <Notifications/>
}])
export default routes