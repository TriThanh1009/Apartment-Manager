﻿using AM.UI.Model;
using Data.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using ViewModel.Furniture;
using ViewModel.Room;
using ViewModel.RoomDetails;
using ViewModel.RoomImage;

namespace AM.UI.State.Store
{
    public class RoomStore
    {
        private readonly Apartment _apartment;
        private readonly List<RoomVm> _roomvm;

        private readonly IRoom _room;
        private readonly IRoomDetails _roomdetails;

        private Lazy<Task> _initializeLazyRoom;
        public List<RoomVm> roomvm => _roomvm;

        private readonly List<RoomDetailsFurniture> _roomdetailsvmfur;

        private readonly List<FurnitureCreateViewModel> _furniturecreatevm;
        private readonly List<RoomImageCreateViewModel> _roomimagevms;

        public List<RoomDetailsFurniture> roomdetailsvmfur => _roomdetailsvmfur;
        public List<RoomImageCreateViewModel> roomimagevms => _roomimagevms;
        public List<FurnitureCreateViewModel> furniturecreatevm => _furniturecreatevm;

        public event Action<RoomVm> RoomAdd;

        public event Action<RoomVm> RoomUpdate;

        public event Action<int> RoomDelete;

        public event Action<RoomImageCreateViewModel> RoomImageAdd;

        public event Action<int> RoomImageDelete;

        public event Action<FurnitureCreateViewModel> RoomFurnitureCreate;

        public RoomStore(Apartment apartment, IRoom room, IRoomDetails roomimages)
        {
            _apartment = apartment;
            _roomvm = new List<RoomVm>();
            _room = room;
            _roomdetails = roomimages;
            _roomimagevms = new List<RoomImageCreateViewModel>();
            _initializeLazyRoom = new Lazy<Task>(InitializeRoom);
        }

        public async Task LoadRoom()
        {
            try
            {
                await _initializeLazyRoom.Value;
            }
            catch (Exception)
            {
                _initializeLazyRoom = new Lazy<Task>(InitializeRoom);
                throw;
            }
        }

        private async Task InitializeRoom()
        {
            List<RoomVm> room = await _room.GetAll();
            _roomvm.Clear();
            _roomvm.AddRange(room);
        }

        public async Task<Room> AddRoom(RoomCreateViewModel request)
        {
            var result = await _room.Create(request);
            RoomVm create = new RoomVm
            {
                ID = result.ID,
                NameLeader = result.IDLeader.ToString(),
                Name = result.Name,
                Quantity = result.Quantity,
            };
            _roomvm.Add(create);
            RoomAdd?.Invoke(create);
            return result;
        }

        public async Task<Room> UpdateRoom(RoomUpdateViewModel request)
        {
            var result = await _room.Update(request);
            RoomVm update = new RoomVm
            {
                ID = result.ID,
                NameLeader = result.IDLeader.ToString(),
                Name = result.Name,
                Quantity = result.Quantity,
            };
            var currentIndex = _roomvm.FindIndex(x => x.ID == result.ID);
            if (currentIndex != -1)
            {
                _roomvm[currentIndex] = update;
            }
            else
            {
                _roomvm.Add(update);
            }
            RoomUpdate?.Invoke(update);
            return result;
        }

        public async Task<bool> DeleteRoom(int id)
        {
            var result = await _room.Delete(id);
            _roomvm.RemoveAll(x => x.ID == id);
            RoomDelete?.Invoke(id);
            return result;
        }

        public async Task<bool> CreateImage(RoomImageCreateViewModel request, string NameFile)
        {
            var result = await _roomdetails.CreateImage(request, NameFile);
            RoomImageCreateViewModel create = new RoomImageCreateViewModel
            {
                ID = request.ID,
                IDroom = request.IDroom,
                Name = request.Name,
                Url = NameFile,
            };
            _roomimagevms.Add(create);
            RoomImageAdd?.Invoke(create);
            return result;
        }

        public async Task<bool> CreateFurniture(FurnitureCreateViewModel request)
        {
            var result = await _roomdetails.CreateFurniture(request);
            FurnitureCreateViewModel create = new FurnitureCreateViewModel
            {
                ID = request.ID,
                Name = request.Name
            };
            _furniturecreatevm.Add(create);
            RoomFurnitureCreate?.Invoke(create);
            return result;
        }

        public async Task<int> DeteleImage(int id)
        {
            var result = await _roomdetails.Delete(id);

            _roomimagevms.RemoveAll(y => y.ID == id);
            RoomImageDelete?.Invoke(id);

            return 1;
        }

        public async Task<List<RoomDetailsImage>> LoadRoomDetailsImage(int id)
        {
            List<RoomDetailsImage> roomdetailsImage = await _apartment.GetAllRoomDetailsImage(id);
            return roomdetailsImage;
        }

        public async Task<List<RoomDetailsFurniture>> LoadRoomDetailsFurniture(int id)
        {
            List<RoomDetailsFurniture> roomdetails = await _apartment.GetAllRoomDetailsFurniture(id);
            return roomdetails;
        }
    }
}