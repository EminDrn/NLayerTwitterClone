import {createBrowserRouter} from "react-router-dom";

import Explore from "../pages/explore";
import Notifications from "../pages/notifications";
import Home from "~/pages/home";
import NotFound from "~/pages/not-found";
import MainLayout from "~/layout/main";

 const routes =  createBrowserRouter([{
    path: '/',
    element: <MainLayout />,
    children : [
        {
            index :true,
            element : <Home />
        },
        {
        
            path: '/explore',
            element: <Explore/>
        },
        {
            path: '/notifications',
            element: <Notifications/>
        },
        {
            path: '*',
            element: <NotFound/>
        }
    ]
}

    ])
export default routes