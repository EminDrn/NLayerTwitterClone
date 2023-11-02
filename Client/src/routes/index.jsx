import {createBrowserRouter} from "react-router-dom";

import Explore from "../pages/explore";
import Notifications from "../pages/notifications";
import Home from "~/pages/home";
import NotFound from "~/pages/not-found";
import MainLayout from "~/layout/main";
import Messages from "~/pages/messages";
import Lists from "~/pages/lists";
import Comminities from "~/pages/comminities";
import Premium from "~/pages/premium";
import Profile from "~/pages/profile";


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
            path: '/messages',
            element: <Messages/>
        },
       
        {
            path: '/lists',
            element: <Lists/>
        } 
        ,
       
        {
            path: '/comminities',
            element: <Comminities/>
        },
        
       
        {
            path: '/premium',
            element: <Premium/>
        }
        ,
       
        {
            path: '/profile',
            element: <Profile/>
        },
          
        
        {
            path: '*',
            element: <NotFound/>
        }
    ]
}

    ])
export default routes